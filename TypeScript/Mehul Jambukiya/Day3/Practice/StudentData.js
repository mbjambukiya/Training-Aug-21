var StudentDataNs;
(function (StudentDataNs) {
    function TotalFeeCalulate(feeAmount, months) {
        return feeAmount * months;
    }
    StudentDataNs.TotalFeeCalulate = TotalFeeCalulate;
})(StudentDataNs || (StudentDataNs = {}));
