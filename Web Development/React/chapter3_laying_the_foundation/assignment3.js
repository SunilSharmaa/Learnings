import React from "react";
import ReactDOM from "react-dom/client";
// import profileImage from "./profile.jpg";

let LeftLogo = ()=> {
    return (<img class="profile-pic" src="https://marketplace.canva.com/EAFEits4-uw/1/0/1600w/canva-boy-cartoon-gamer-animated-twitch-profile-photo-oEqs2yqaL8s.jpg" alt="logo image" />);
}

let SearchBar = ()=> {
    return (<img class="search" src="https://cdn-icons-png.flaticon.com/128/326/326740.png" alt="searchbar image"></img>);
}

let RightLogo = ()=> {
    return (<img class="users" src="https://cdn-icons-png.flaticon.com/128/456/456212.png" alt="user logo"></img>);
}

let HeaderContainer = ()=> {
    return (
        <div class="header">
            {<LeftLogo />}
            {<SearchBar />}
            {<RightLogo />}
        </div>

    )
}

let root = ReactDOM.createRoot(document.getElementById("container"));
root.render(<HeaderContainer />);