    document.addEventListener("DOMContentLoaded", function () {
        var roleDropdown = document.getElementById("Role"); // Assuming "Role" is the id of the role dropdown

    roleDropdown.addEventListener("change", function () {
            var selectedRole = roleDropdown.value;
    var branchDropdownContainer = document.getElementById("branchDropdownContainer");

    if (selectedRole === "Super Admin") {
        branchDropdownContainer.style.display = "none";
            } else {
        branchDropdownContainer.style.display = ""; // Show the branch dropdown if the role is not "Super Admin"
            }
        });
    });

