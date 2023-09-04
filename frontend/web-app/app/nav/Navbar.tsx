import React from "react";
import Search from "./Search";
import Logo from "./Logo";

export default function Navbar() {
  console.log("Client component");
  return (
    <header
      className="
      sticky top-0 z-50 flex justify-between bg-white p-5 mb-2 items-center text-gray-800 shadow-md
    "
    >
      <Logo />
      <Search />
      <div>Login</div>
    </header>
  );
}
