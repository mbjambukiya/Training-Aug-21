"use strict";
exports.__esModule = true;
exports.DisplayString = exports.varifyLength = void 0;
function varifyLength(str) {
    if (str.length < 10) {
        return true;
    }
    else {
        return false;
    }
}
exports.varifyLength = varifyLength;
function DisplayString(str) {
    console.log(str);
}
exports.DisplayString = DisplayString;
function Sum(a, b) {
    console.log(a + b);
}
exports["default"] = Sum;
;
