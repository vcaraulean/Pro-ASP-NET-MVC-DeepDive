function processResponse(appt) {
    $("#successClientName").text(appt.ClientName);
    $("#successDate").text(processDate(appt.Date));
    switchViews();
}

var processDate = function (date) {
    return new Date(parseInt(date.substr(6, date.length - 8))).toDateString();
};

var switchViews = function () {
    var hidden = $(".hidden");
    var visible = $(".visible");

    hidden.removeClass("hidden").addClass("visible");
    visible.removeClass("visible").addClass("hidden");
};

$(document).ready(function () {
    $("#backButton").click(function (e) {
        switchViews();
    });
});
