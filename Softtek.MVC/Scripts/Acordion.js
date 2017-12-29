$(document).ready(setAcordion);

function setAcordion() {
    var acc = document.getElementsByClassName("accordion");
    var i;

    for (i = 0; i < acc.length; i++) {
        acc[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.maxHeight) {
                panel.style.maxHeight = null;
            } else {
                panel.style.maxHeight = panel.scrollHeight + "px";
            }
        });
    }


    function changeText() {
        document.getElementById('FirstP').innerHTML = document.getElementById("NewText").value;
    }

    document.getElementById("b1").onclick = changeText;

};




