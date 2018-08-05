/*!
 * /////////// MFM.Wool.GlossaryTermLib.js ///////////
 *
 * Author: Mohamed Farouk
 * Summary: Handling Client Side processing of GlossaryTermLib app. Depends on JQuery, Bootstrap 4.
 * License: Open
 * Version: 1.0B
*/

window.Wool = window.Wool || {};
Wool.GlossaryTermLib = function (GlossaryTermLib, $) {
	GlossaryTermLib.PageSize = 6;
    GlossaryTermLib.SortBy = '';
    GlossaryTermLib.Data = null;

    GlossaryTermLib.LoadGlossaryTermLibs = function (start, page) {
        GlossaryTermLib.PaginationLoaded = false;
        $("#GlossaryTermLibsList").html('<div class="col"><div class="alert alert-warning" role="alert">Loading GlossaryTermLibs please wait..</div></div>');
        $.ajax("/api/GlossaryTerm/getall/")
            .done(function (data) {
                GlossaryTermLib.Data = data.glossaryTerms;
                var _html = '<ul class="list-group">';
                for (var i = 0; i < GlossaryTermLib.Data.length; i++)
                {
                    var _GlossaryTermLib = GlossaryTermLib.Data[i];
                    _html += '<li href="#" class="list-group-item list-group-item-action flex-column align-items-start"><div class="d-flex w-100 justify-content-between">' +
                        '    <h6 class="float-left">(' + (i + 1) + ') ' + _GlossaryTermLib.term + '</h6>' +
                        '    <div class="float-right">' +
                        '       <button onclick="Wool.GlossaryTermLib.ShowTermForm(Wool.GlossaryTermLib.Data['+i+']);" class="btn btn-primary btn-sm">Edit</button> &nbsp; ' +
                        '       <button onclick="Wool.GlossaryTermLib.ShowDeleteTerm(Wool.GlossaryTermLib.Data[' + i + '],' + i +');" class="btn btn-outline-danger btn-sm float-right">Delete</button>' +
                        '    </div>'+
                        '   </div>' +
                        '   <p class="mb-1">' + _GlossaryTermLib.definition + '</p>' +
                        '</li>';
                }
                _html += '</ul>';

                $("#GlossaryTermLibsList").html(_html);
		  })
		  .fail(function () {
  			alert("Error recieved from server");
            });

        GlossaryTermLib.ShowTermForm = function (term) {
            if (term) {
                $("#Id").val(term.id);
                $("#Term").val(term.term);
                $("#Definition").val(term.definition);
            }
            else
            {
                $("#Id").val("");
                $("#Term").val("");
                $("#Definition").val("");
            }
            $('#termModal').modal('show');
        };

        GlossaryTermLib.SaveGlossaryTerm = function () {
            $(".form-item").prop('disabled', true);
            $(".form-save").text("Saving");
            var data = { Id: $("#Id").val(), Term: $("#Term").val(), Definition: $("#Definition").val() };
            $.post("/api/GlossaryTerm/save", data)
                .done(function (data) {
                    if (data.success) {
                        $('#termModal').modal('hide');
                        GlossaryTermLib.LoadGlossaryTermLibs();
                        $(".form-item").val("");
                    }
                    else {
                        alert("Error: " + data.message);
                    }
                })
                .fail(function () {
                    alert("Error recieved from server");
                });
            $(".form-item").prop('disabled', false);
            $(".form-save").text("Save Changes");
        };

        GlossaryTermLib.ShowDeleteTerm = function (term, index) {
            if (term) {
                $("#del-Index").val(index);
                $("#del-term").text(term.term);
            }
            $('#delTermModal').modal('show');
        };

        GlossaryTermLib.DeleteGlossaryTerm = function () {
            $(".form-item").prop('disabled', true);
            $(".form-delete").text("Deleting");
            $.post("/api/GlossaryTerm/delete", Wool.GlossaryTermLib.Data[parseInt($("#del-Index").val())])
                .done(function (data) {
                    if (data.success) {
                        $('#delTermModal').modal('hide');
                        GlossaryTermLib.LoadGlossaryTermLibs();
                    }
                    else {
                        alert("Error: " + data.message);
                    }
                })
                .fail(function () {
                    alert("Error recieved from server");
                });
            $(".form-item").prop('disabled', false);
            $(".form-delete").text("Delete");
        };
    };
    return GlossaryTermLib;
}(Wool.GlossaryTermLib = Wool.GlossaryTermLib || {}, jQuery);