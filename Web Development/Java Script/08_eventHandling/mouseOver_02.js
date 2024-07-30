let image1 = document.getElementById("image1");
        image1.onmouseover = () => {
            // alert(`working fine`)
            image1.setAttribute("src", "sample2.jpg")
        }

        image1.onmouseout = () => {
            // alert(`work fine 2`)
            image1.setAttribute("src", "sample1.jpg")
        }