using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;
using GetSkilled.Models;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetSkilled.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = UserRoles.Admin)]
    public class DocumentController : ControllerBase
    {
        private readonly IDocument _document;
        private readonly IMapper _mapper;
        public DocumentController(IDocument document, IMapper mapper)
        {
            _document = document;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetDocumentList()
        {
            try
            {
                var result = _document.GetAllData();
                var documentList = new List<DocumentDto>();
                foreach (var i in result)
                {
                    if (i.IsDeleted == false)
                    {
                        documentList.Add(_mapper.Map<DocumentDto>(i));
                    }
                }
                if (documentList.Any())
                {
                    return Ok(documentList);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{documentId}")]
        public IActionResult GetDocumentById(int documentId)
        {
            try
            {
                var result = _document.GetDataById(documentId);

                if (result != null && result.IsDeleted == false)
                {
                    return Ok(_mapper.Map<DocumentDto>(result));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult AddDocument(Document document)
        {
            try
            {
                document.LastModified = DateTime.Now;
                var result = _document.CreateData(document);
                if (result == true)
                {
                    _document.SaveData();
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut()]
        public IActionResult UpdateDocument(Document document)
        {
            try
            {
                document.LastModified = DateTime.Now;
                if (document.IsDeleted == false)
                {
                    var result = _document.UpdateData(document);
                    if (result == true)
                    {
                        _document.SaveData();
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{documentId}")]
        public IActionResult DeleteDocument(int documentId)
        {
            try
            {
                var result = _document.DeleteData(documentId);
                if (result == true)
                {
                    _document.SaveData();
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
