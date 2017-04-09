var connector = (function () {

    var _addInstruction = function () {
        var header = new fabric.Text("Instructions", {
            fontSize: 22,
            fontWeight: 'bold',
            top: 50
        });

        var content = new fabric.Text("1. select left end connector\n2. select cable / ruggedisation\n3. select right end connector", {
            fontSize: 18,
            top: 80
        });

        var group = new fabric.Group([header, content], {
            left: 140,
            top: 30,
            selectable: false
        });

        window.canvas.add(group).renderAll();
    };

    var _renderCableParts = function (partsId, Src, Left, Top, Width, Height) {
        window.canvas.getObjects().forEach(function (obj, index) {
            if (obj.type == "group") {
                canvas.remove(obj).renderAll();
            }

        });

        window.canvas.getObjects().forEach(function (obj, index) {
            if (obj.id == partsId) {
                canvas.remove(obj);
            }

        });
        var img = new Image();
        img.src = Src;
        img.onload = function () {
            var image = new fabric.Image(img);
            image.set({
                left: Left,
                top: Top,
                width: Width,
                height: Height,
                selectable: false,
                id: partsId
            });
            window.canvas.add(image);
        }
        window.canvas.renderAll();


    };

    var dataURItoBlob = function (dataURI) {
        // convert base64/URLEncoded data component to raw binary data held in a string
        var byteString;
        if (dataURI.split(',')[0].indexOf('base64') >= 0)
            byteString = atob(dataURI.split(',')[1]);
        else
            byteString = unescape(dataURI.split(',')[1]);

        // separate out the mime component
        var mimeString = dataURI.split(',')[0].split(':')[1].split(';')[0];

        // write the bytes of the string to a typed array
        var ia = new Uint8Array(byteString.length);
        for (var i = 0; i < byteString.length; i++) {
            ia[i] = byteString.charCodeAt(i);
        }

        return new Blob([ia], { type: mimeString });
    };

    var _updateConnectedRightEnd = function (id) {
        $('#rightGroup').html('');
        $.post("/Connector/GetConnectedRightEndList", {id: id}, function (data) {
            //console.log(data);
            data.forEach(function (obj, index) {
                var button = '<button class="btn btn-info custom" name="right ' + obj.Id + '" onclick="connector.loadRightEndImage(' + obj.Id + ' );">' + obj.Name + '</button>';
                   $('#rightGroup').append(button);
            });
            var button = '<button class="btn custom" style="background-color: lightblue; color:#fff;" onclick="connector.implementNone();">none</button>';
            $('#rightGroup').append(button);
        }).error(function (xhr, status, error) {
            //debugger;
        });
     
    };

    var _updateConnectedLeftEnd = function (id) {
        $('#leftGroup').html('');
        $.post("/Connector/GetConnectedLeftEndList", { id: id }, function (data) {
            //console.log(data);
            data.forEach(function (obj, index) {
                var button = '<button class="btn btn-info custom" name="left ' + obj.Id + '" onclick="connector.loadLeftEndImage(' + obj.Id + ' );">' + obj.Name + '</button>';
                $('#leftGroup').append(button);
            });
            
        }).error(function (xhr, status, error) {
            //debugger;
        });

    };

    return {
        init: function () {
            window.canvas = new fabric.Canvas('canvas');
            canvas.setHeight($('.canvas-container').height());
            canvas.setWidth($('.canvas-container').width());
            //canvas.setBackgroundColor('#ccc');
            _addInstruction();

            // All event bindings goes here
            $('#cableList,#connectorTypeList').dataTable();

            $('.unit-radio input[type="radio"]').each(function (index, obj) {
                $(obj).change(function (e) {

                    var selectedValue = e.target.value;

                    $('.unit-radio input[type="radio"]').each(function (index, obj) {
                        if (obj.value != selectedValue) {
                            obj.checked = false;
                        }

                    });
                });
            });
        },
        loadLeftEndImage: function (id) {
            window.selectedLeftEndIndex = id;

            $('#leftGroup button').each(function (index, btn) {
                //console.log(btn);
                if (btn.name == "left " + id) {
                    $(btn).css('background', '#428bca');
                } else {
                    $(btn).css('background', '#5bc0de');
                }

            });

            $.post("/Connector/GetLeftImages", { id: id }).then(function (data) {
                //console.log(data);
                $('.left-end').html('');
                data[0].forEach(function (element, index) {
                    //console.log(element);                   
                    var img = '<a><img onclick="connector.loadLeftImageInCanvas(this.src)" src=' + element.RelativePath + ' width="90" height="80" style="margin: 2px 0px 2px 2px;" class="img-thumbnail" > </a>';
                    $('.left-end').append(img);
                });

            });

            _updateConnectedRightEnd(id);
        },
        loadRightEndImage: function (id) {
            window.selectedRightEndIndex = id;
            $('#rightGroup button').each(function (index, btn) {
                //console.log(btn);
                if (btn.name == "right " + id) {
                    $(btn).css('background', '#428bca');
                } else {
                    $(btn).css('background', '#5bc0de');
                }

            });
            $('#rightGroup button').last().css('background-color', 'lightblue');

            $.post("/Connector/GetRightImages", { id: id }).then(function (data) {

                $('.right-end').html('');
                data[0].forEach(function (element, index) {
                    //console.log(element);                  
                    var img = '<a><img onclick="connector.loadRightImageInCanvas(this.src)" src=' + element.RelativePath + ' width="90" height="70" style="margin: 2px 0px 2px 2px;" class="img-thumbnail" > </a>';
                    $('.right-end').append(img);

                });
            });
            $('.right-end').show();
            $('.none').hide();
            _updateConnectedLeftEnd(id);

        },
        loadLeftImageInCanvas: function (e) {
            // _renderCableParts= function( partsId,Src,Left,Top,Width,Height );
            //_renderCableParts("leftEnd", e, 40, 130, 80, 70);
            _renderCableParts("leftEnd", e, 100, 92, 91, 56);
            $('#leftConnectorSelector').prop('href', '#leftConnectorTypeModal');
        },
        loadRightImageInCanvas: function (e) {
            // _renderCableParts= function( partsId,Src,Left,Top,Width,Height );
            //_renderCableParts("rightEnd", e, 336, 130, 91, 56);
            _renderCableParts("rightEnd", e, 380, 92, 91, 56);
            //debugger;
            $('#rightConnectorSelector').prop('href', '#rightConnectorTypeModal');
        },
        resetConfiguration: function () {

            window.canvas.clear();
            _addInstruction();

            $('#leftConnectorSelector').prop('href', '');
            $('#rightConnectorSelector').prop('href', '');
            $('.selected-cable-desc').html('Selected: none');
            $('.selected-leftend-desc').html('Selected: none');
            $('.selected-rightend-desc').html('Selected: none');
            $('#testImg').prop('src', '/content/image/ic_test-notok.gif');
            $('#goBasket').css('display', 'none');
            $('.connectorType-left').html('');
            $('.connectorType-right').html('');
            $('.configuration-name input').val('');
            $('#lengthError').html('');
            $('.tolerance').css('display', 'none');
            $('.unit-length').val('');
            $('.unit-radio input[type="radio"]').each(function (index, obj) {
                obj.checked = false;
            });

            $('#leftRed').css('color', '');
            $('#leftConnectorSelector').css('color', '#000');

            $('#middleRed').css('color', '');
            $('#cableLink').css('color', '#000');

            $('#rightRed').css('color', '');
            $('#rightConnectorSelector').css('color', '#000');

            $('#resetModal').modal('hide');


            $('.none').hide();
            $('.right-end').show();
            $('.right-end').html('');
            $('.left-end').html('');
        },
        addWireInCanvas: function () {
            var selectedCableIndex;
            $('#cableList input[type="radio"]').each(function (index, element) {
                if (element.checked) {
                    selectedCableIndex = element.name;
                }
            });

            if (selectedCableIndex) {
                $.post("/Connector/GetCableById", { id: selectedCableIndex }).then(function (data) {
                    //console.log(data);
                    // _renderCableParts= function( partsId,Src,Left,Top,Width,Height );
                    //_renderCableParts("cableWire", data.Images[0].RelativePath, 104, 40, 250, 250);
                    _renderCableParts("cableWire", data.Images[0].RelativePath, 170, 30, 230, 180);
                    //debugger;
                    $('.selected-cable-desc').html("selected: " + data.Description);
                    $('.selected-cable-desc').attr('name', data.Id);


                });
            }
            $('#middleRed').css('color', '#428bca');
            $('#cableLink').css('color', '');
            $('#cableModal').modal('hide');
        },
        manageRadio: function (id) {
            $('#cableList input[type="radio"]').each(function (index, element) {
                //console.log(element.name);
                if (element.name != id) {
                    element.checked = false;
                }
                $('#btnApply').prop("disabled", false);
            });

        },
        manageLeftTypeRadio: function (id) {
            $('#leftConnectorTypeModal input[type="radio"]').each(function (index, element) {
                //console.log(element.name);
                if (element.name != id) {
                    element.checked = false;
                }
            });
            $('#btnLeftConnectorTypeApply').prop("disabled", false);
        },
        manageRightTypeRadio: function (id) {
            $('#rightConnectorTypeModal input[type="radio"]').each(function (index, element) {
                //console.log(element.name);
                if (element.name != id) {
                    element.checked = false;
                }
            });
            $('#btnRightConnectorTypeApply').prop("disabled", false);
        },
        addLeftTypeImage: function () {
            var selectedCableIndex;
            $('#leftConnectorTypeModal input[type="radio"]').each(function (index, element) {
                if (element.checked) {
                    selectedCableIndex = element.name;
                }
            });

            if (selectedCableIndex) {
                $.post("/Connector/GetLeftConnectorType", { id: selectedCableIndex }, function (data) {
                    //debugger;
                    $('.connectorType-left').html('');
                    //console.log(data);
                    var img ='<p class="square" style="margin:10px 0px 2px 0px;">'+
                             '<span><a style="font-weight: bold;font-size:12px;">Select Reference Point Left</a></span></p>' +
                             '<p style="margin:0px 0px 0px 20px; font-size:12px;"><b>Default: </b>Tip</p>' +
                             '<a><img name='+data.Id+' src=' + data.Image.RelativePath +
        			         ' width="90" height="70" style="margin: 2px;"> </a>';
                    $('.connectorType-left').append(img);

                    $('.selected-leftend-desc').html("selected: " + data.Type);

                }).error(function (xhr, status, error) {
                    //debugger;
                });
            }

            $('#leftRed').css('color', '#428bca');
            $('#leftConnectorSelector').css('color', '');
            $('#leftConnectorTypeModal').modal('hide');

        },
        addRightTypeImage: function () {
            var selectedCableIndex;
            $('#rightConnectorTypeModal input[type="radio"]').each(function (index, element) {
                if (element.checked) {
                    selectedCableIndex = element.name;
                }
            });

            if (selectedCableIndex) {
                $.post("/Connector/GetRightConnectorType", { id: selectedCableIndex }, function (data) {
                    //debugger;
                    $('.connectorType-right').html('');
                    //console.log(data);
                    var img = '<p class="square" style="margin:10px 0px 2px 0px;">' +
                              '<span><a style="font-weight: bold;font-size:12px;">Select Reference Point Right</a></span></p>' +
                              '<p style="margin:0px 0px 0px 20px; font-size:12px;"><b>Default: </b>Tip</p>' +
                              '<a><img name=' + data.Id + ' src=' + data.Image.RelativePath +
        			          ' width="90" height="70" style="margin: 2px;"> </a>';

                    $('.connectorType-right').append(img);

                    $('.selected-rightend-desc').html("selected: " + data.Type);

                }).error(function (xhr, status, error) {
                    //debugger;
                });
            }

            $('#rightRed').css('color', '#428bca');
            $('#rightConnectorSelector').css('color', '');
            $('#rightConnectorTypeModal').modal('hide');
        },
        checkLeftTypeValidity: function () {
            if ($('#leftConnectorSelector').attr('href') == '') {
                $('.redtext-lefttype').css('display', 'block');
            } else {
                $('.redtext-lefttype').css('display', 'none');
            }

        },
        checkRightTypeValidity: function () {
            if ($('#rightConnectorSelector').attr('href') == '') {
                $('.redtext-righttype').css('display', 'block');
            } else {
                $('.redtext-righttype').css('display', 'none');
            }

        },
        implementNone: function(){
            $('.right-end').hide();
            $('.none').show();
            window.canvas.getObjects().forEach(function (obj, index) {
                if (obj.id == 'rightEnd') {
                    canvas.remove(obj);
                }

            });

        },
        checkout: function () {

            var leftEnd = false, rightEnd = false, cableWire = false, isConfigurationOk = true;

            window.canvas.getObjects().forEach(function (obj) {
                if (obj.id == "leftEnd") {
                    leftEnd = true;
                }
                if (obj.id == "rightEnd") {
                    rightEnd = true;
                }
                if (obj.id == "cableWire") {
                    cableWire = true;
                }
            });


            if (!leftEnd) {
                $('#leftRed').css('border-color', 'red');
            } else {
                $('#leftRed').css('border-color', 'rgba(0,0,255, 0.3)');
            }

            if (!rightEnd) {
                $('#rightRed').css('border-color', 'red');
            } else {
                $('#rightRed').css('border-color', 'rgba(0,0,255, 0.3)');
            }

            if (!cableWire) {
                $('#middleRed').css('border-color', 'red');
            } else {
                $('#middleRed').css('border-color', 'rgba(0,0,255, 0.3)');
            }

            if (!leftEnd || !rightEnd || !cableWire) {
                isConfigurationOk = false;
            }

            if ($('.configuration-name input').val() == '') {
                $('.configuration-name').css('border-color', '#f00');
                isConfigurationOk = false;
            } else {
                $('.configuration-name').css('border-color', 'rgba(0,0,255, 0.3)');
            }

            if ($('.tolerance').css('display') == 'none') {
                $('.length-config').css('border-color', '#f00');
                isConfigurationOk = false;
            } else {
                $('.length-config').css('border-color', 'rgba(0,0,255, 0.3)');
            }


            if (isConfigurationOk) {
                $('#testImg').prop('src', '/content/image/ic_test-ok.gif');
                $('#goBasket').css('display', 'block');
            } else {
                $('#testImg').prop('src', '/content/image/ic_test-notok.gif');
                $('#goBasket').css('display', 'none');
            }
        },
        //export: function () {
        //    var dataURL = window.canvas.toDataURL("image/png");
        //    var doc = new jsPDF();
        //    var img = new Image();
        //    img.onload = function () {
        //        doc.addImage(img, 'PNG', 20, 10, 50, 12);
        //        doc.addImage(dataURL, 'PNG', 15, 48, 180, 80); 
        //        var configuration = doc.output('blob');
        //        var formdata = new FormData();
        //        formdata.append("configuration", configuration);
        //        var xhr = new XMLHttpRequest();
        //        xhr.open('POST', '/Connector/SaveDesign');
        //        xhr.send(formdata);
        //        xhr.onreadystatechange = function () {
        //            if (xhr.readyState == 4 && xhr.status == 200) {
        //                window.location.href = "/Connector/Export";
        //            }
        //        }
        //    }
        //    img.src = "/Content/image/tactron-logo-claim.png";
        //    doc.setFontSize(25);
        //    doc.setTextColor(165,42,42);
        //    doc.text(75, 15, "Tactron assembly data sheet");
        //    doc.setFontSize(20);
        //    doc.text(95, 25, "Flexible RF cable");
        //    doc.setFontSize(15);
        //    doc.setFontType("bold");
        //    doc.setTextColor(0, 0, 0);
        //    doc.text(35, 45, "Configuration: " + $('.configuration-name input').val());
        //    doc.setLineWidth(.2);
        //    doc.setDrawColor(221, 221, 221);
        //    doc.rect(14, 39, 182, 90); // empty red square
        //    doc.setLineWidth(.1);
        //    doc.line(14.1, 47.5, 195.9, 47.5);              

        //},
        export: function () {

            var unit;
            $('.unit-radio input[type="radio"]').each(function (index, obj) {
                if (obj.checked) {
                    unit = obj.name;
                }
            });

            var model = {
                 ConfigName: $('.configuration-name input').val(),
                 LeftConnectorTypeId: $('.connectorType-left img').prop('name') || 1,
                 RightConnectorTypeId: $('.connectorType-right img').prop('name') || 1,
                 CableId: $('.selected-cable-desc').attr('name'),
                 Length: $('.unit-length').val(),
                 Unit: unit,
                 StandardTolerance: '.12',
                 ChoosenTolarance: '.1',
            };
            
            var dataURL = window.canvas.toDataURL("image/png");    
            var configuration = dataURItoBlob(dataURL);
            var formdata = new FormData();
            formdata.append("FullImage", configuration);
            formdata.append("model", JSON.stringify( model));           

            var xhr = new XMLHttpRequest();
            xhr.open('POST', '/Connector/GeneratePDF');
            xhr.send(formdata);
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4 && xhr.status == 200) {
                    window.location.href = "/Connector/Export";
                    console.log("success");
                }
            }

        },
        checkLengthValidation: function () {

            var length = $('.unit-length').val();

            if (length == '') {
                $('#lengthError').html(' Please enter the length');
                $('.tolerance').css('display', 'none');
                return;
            } else {
                $('#lengthError').html('');
            }

            var selectedValue;
            $('.unit-radio input[type="radio"]').each(function (index, obj) {
                if (obj.checked) {
                    selectedValue = obj.value;
                }
            });

            if (!selectedValue) {
                $('#lengthError').html('Please select unit');
                $('.tolerance').css('display', 'none');
                return;
            } else {
                $('#lengthError').html('');
            }

            if (selectedValue == '1') {
                if (parseFloat(length) < 2.76) {
                    $('#lengthError').html('minimum length 2.76 inches');
                    $('.tolerance').css('display', 'none');
                    return;
                } else {
                    $('#stdTolerance').html('Standard tolerance: +/-2mm per inches');
                    $('#lengthError').html('');
                }
            }

            if (selectedValue == '2') {
                if (parseFloat(length) < .23) {
                    $('#lengthError').html('minimum length .23 feet');
                    $('.tolerance').css('display', 'none');
                    return;
                } else {
                    $('#stdTolerance').html('Standard tolerance: +/-.12 inches per feet');
                    $('#lengthError').html('');
                }
            }

            if (selectedValue == '3') {
                if (parseFloat(length) < 70) {
                    $('#lengthError').html('minimum length 70 mm');
                    $('.tolerance').css('display', 'none');
                    return;
                } else {
                    $('#stdTolerance').html('Standard tolerance: +/- 3mm');
                    $('#lengthError').html('');
                }
            }

            if (selectedValue == '4') {
                if (parseFloat(length) < .07) {
                    $('#lengthError').html('minimum length .07 meter');
                    $('.tolerance').css('display', 'none');
                    return;
                } else {
                    $('#stdTolerance').html('Standard tolerance: +/- 10mm per meter');
                    $('#lengthError').html('');
                }
            }

            $('.tolerance').css('display', 'block');


        }

    }
})();

$(document).ready(function () {
    connector.init();

    $("#fileInputLeft").change(function (e) {

        if (!window.selectedLeftEndIndex) {
            alert('no left end connector is selected');
            return;
        }

        var formdata = new FormData(); //FormData object
        for (i = 0; i < e.target.files.length; i++) {
            //Appending each file to FormData object
            formdata.append(e.target.files[i].name, e.target.files[i]);
        }

        formdata.append('id', selectedLeftEndIndex);

        //Creating an XMLHttpRequest and sending
        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/Connector/UploadLeftEndConnector');
        xhr.send(formdata);
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
                connector.loadLeftEndImage(selectedLeftEndIndex);
                //alert(xhr.responseText);
            }
            if (xhr.readyState == 4 && xhr.status == 404) {
                alert(xhr.responseText);
            }
        }

    });

    $("#fileInputRight").change(function (e) {

        if (!window.selectedRightEndIndex) {
            alert('no right end connector is selected');
            return;
        }

        var formdata = new FormData(); //FormData object
        for (i = 0; i < e.target.files.length; i++) {
            //Appending each file to FormData object
            formdata.append(e.target.files[i].name, e.target.files[i]);
        }

        formdata.append('id', selectedRightEndIndex);

        //Creating an XMLHttpRequest and sending
        var xhr = new XMLHttpRequest();
        xhr.open('POST', '/Connector/UploadRightEndConnector');
        xhr.send(formdata);
        xhr.onreadystatechange = function () {
            if (xhr.readyState == 4 && xhr.status == 200) {
                connector.loadRightEndImage(selectedRightEndIndex);
                //alert(xhr.responseText);
            }
            if (xhr.readyState == 4 && xhr.status == 404) {
                alert(xhr.responseText);
            }
        }

    });


});