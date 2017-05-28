﻿// here i am to write a JS for the search operations

$(function () {

    //$('#search-btn').click(function () {
    //    console.log("It Works")
    //})


    //$('.searcher').change(function () {

    //    console.log('Changed');
    //    var caurrentId = $(this).attr('id');
    //    var currentval = $(this).val();

    //})

    var srch_btn = $('#search-btn')
    var srch_selections = $('#search-panel:selected').val();
    var updateCarList = function (resp) {
        $('#car-list-displayed').remove();

    }
    var printError = function (req, status, err) {
        console.log('Fail to proccess function, got error:', status, err);
    }
    var ajaxOptions = {
        url: '/Search/GetCarsByCriterion',
        cretiria:srch_selections,
        dataType: 'json',
        success: updateCarList,
        error: printError
    }
    srch_btn.click(function () {
        // var caurrentId = $('.ModelTypeSelect :selected').attr('selected', 'selected').val();
        var currentFreeTextSearch = $('.FreeSearchText input');
        var currentFreeTextSearchSrting = currentFreeTextSearch.val();
        var currentGearTypeSelection = $('.GearSelect :selected');
        var currentGearTypeSelection = $('.GearSelect :selected').attr('selected', 'selected');
        var currentGearTypeval = currentGearTypeSelection.val();
        var currentModelTypeSelection = $('.ModelTypeSelect :selected').attr('selected', 'selected');
        var currentModelTypeval = currentModelTypeSelection.val();

        var myData = JSON.stringify({
            'SearchGear': currentGearTypeval,
            'SearchModel': currentModelTypeval,
            'SearchText': currentFreeTextSearchSrting
        });
        ajaxOptions['data'] = myData;
        $.ajax(ajaxOptions)
    })
});

