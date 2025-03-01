﻿// CALORIES CALCULATOR =================================



$(document).ready(function() {
    $("#selectBtn").bind("click", function() {
        calc_calories()
    });
    $("input[name=Male]").prop("checked", !0);
    $("input[name=Female]").prop("checked", !1);
    $("input[name=Male]").bind("click", function() {
        $("input[name=Female]").prop("checked", !$(this).prop("checked"))
    });
    $("input[name=Female]").bind("click", function() {
        $("input[name=Male]").prop("checked", !$(this).prop("checked"))
    })
});

function calc_calories() {
    switch ($("[name=calculator]").val()) {
        case "daily_calorie":
            calc_daily_calorie();
            break;
        case "bmr_type":
            calc_BMR();
            break;
        case "bmi_calculator":
            calc_BMI();
            break;
        case "easy_burned":
            calc_easy_burned();
            break;
        case "adv_calculator":
            calc_adv_calculator()
    }
}

function calc_BMR() {
    var a;
    a = "kilo" == $("[name=weight_select]").val() ? parseFloat($("[name=Weight]").val()) : 6.23 * parseFloat($("[name=Weight]").val()) / 13.7;
    var b = "cm" == $("[name=height_select]").val() ? parseFloat($("[name=Height]").val()) : 12.7 * parseFloat($("[name=Height]").val()) / 5, c = parseFloat($("[name=Age]").val());
    if (0 >= b || 0 >= a || 0 >= c)
        return $("#indicator").text("Please complete the form!"), $("#bmr_value").text(""), -1;
    a = $("input[name=Male]").prop("checked") ? 66 + 13.7 * a + 5 * b - 6.8 * c : 655 + 9.6 * a + 1.8 * b - 4.7 * c;
    0 >= a ? ($("#bmr_value").text(""), $("#indicator").text("No kidding.Did you input the right value")) : ($("#bmr_value").text(a.toFixed(2)), $("#indicator").text("See your customized data below:"));
    return a
}

function calc_BMI() {
    var a = "kilo" == $("[name=weight_select]").val() ? parseFloat($("[name=Weight]").val()) : 0.45359237 * parseFloat($("[name=Weight]").val()), b = "cm" == $("[name=height_select]").val() ? parseFloat($("[name=Height]").val()) : 2.54 * parseFloat($("[name=Height]").val());
    0 == b ? ($("#bmi_value").text(""), $("#bmi_level").text(" "), $("#indicator").text("Məlumatları daxil edin")) : (a = 1E4 * a / (b * b), $("#bmi_value").text(a.toFixed(2)), 30 < a ? ($("#bmi_level").text("Obese"), $("#indicator").text("Çəkiniz çoxdur. (Obez)")) : 25 < a ? ($("#bmi_level").text("Overweight"), $("#indicator").text("Çəkiniz çoxdur ")) : 18.5 < a ? ($("#bmi_level").text("Normal"), $("#indicator").text("Təbriklər! Çəkiniz normaldır.")) : 16.5 < a ? ($("#bmi_level").text("Underweight"), $("#indicator").text("Çəkiniz azdır. Kalori ehtiyacınızı müəyyən edin.")) : 0 < a ? ($("#bmi_level").text("Serverely Underweight"), $("#indicator").text("Çəkiniz həddən artıq azdır.")) : ($("#bmi_value").text(""), $("#bmi_level").text(""), $("#indicator").text("Məlumatları daxil edin")))
}
function calc_daily_calorie() {
    var a = calc_BMR();
    if (0 > a)
        $("#your_cal_intake").text("------");
    else {
        var b;
        switch ($("[name=exercise_level]").val()) {
            case "nospec":
                b = 1;
                break;
            case "sedentary":
                b = 1.2;
                break;
            case "light":
                b = 1.375;
                break;
            case "moderate":
                b = 1.55;
                break;
            case "hard":
                b = 1.725;
                break;
            case "nonstop":
                b = 1.9;
                break;
            default:
                b = 1
        }
        a *= b;
        $("#your_cal_intake").text(a.toFixed(2))
    }
}

function calc_easy_burned_unit(a, b) {
    var c = 0, d;
    for (d in b) {
        var e = parseFloat($("[name=hours_" + d + "]").val());
        0 > e && (e = 0);
        $("input[name=" + d + "]").prop("checked") && (e = b[d] * e * a, $("#" + d + "_value").text(e.toFixed(2)), c += e)
    }
    return c
}

function calc_easy_burned() {
    var a = "kilo" == $("[name=weight_select]").val() ? parseFloat($("[name=Weight]").val()) : 0.45359237 * parseFloat($("[name=Weight]").val());
    if (0 > a)
        $("#indicator").text("Are you human bing? Are your in 3-D world?!"), $("#easy_cal_burned").text("------");
    else
    {
        var b = calc_easy_burned_unit(a, MET_DATA_LIA);
        $("#lia_total").text(b.toFixed(2));

        
        $("#easy_cal_burned").text((b).toFixed(2));
        $("#indicator").text("See your customized data below:")
    }
}
function calc_adv_calculator() {
    var a = "kilo" == $("[name=weight_select]").val() ? parseFloat($("[name=Weight]").val()) : 0.45359237 * parseFloat($("[name=Weight]").val()), b = parseFloat($("[name=heartrate]").val()), c = parseFloat($("[name=Age]").val()), d = parseFloat($("[name=duration]").val());
    0 > c || 0 > b || 0 > a ? ($("#indicator").text("Please complete the form!"), $("#adv_calculator_value").text("")) : (0 > d && (d = 0), results = $("input[name=Male]").prop("checked") ? (0.2017 * c + 0.1988 * a + 0.6309 * b - 55.0969) * d / 4.184 : (0.074 * c - 0.1263 * a + 0.4472 * b - 20.4022) * d / 4.184, 0 >= results ? ($("#adv_calculator_value").text("------"), $("#indicator").text("No kidding! Did you input the right value?")) : ($("#adv_calculator_value").text(results.toFixed(3)), $("#indicator").text("See your customized data below:")))
};// JavaScript Document