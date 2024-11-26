document.getElementById("funFactButton").addEventListener("click", function() {
    const factDiv = document.getElementById("funFact");
    factDiv.innerHTML = "<p><strong>Fun Fact:</strong> Luna Bright titkos hobbijai közé tartozik a zene írása és a vidéki kertek létrehozása!</p>";
    factDiv.style.backgroundColor = "#e0f7fa";  // Add a little color change for fun fact
    factDiv.style.border = "1px solid #00bcd4";
});

document.getElementById("addFactButton").addEventListener("click", function() {
    const factsList = document.getElementById("factsList");
    const newFact = prompt("Addj egy új érdekes adatot Luna Bright-ról:");
    
    if (newFact) {
        const newFactItem = document.createElement("li");
        newFactItem.textContent = newFact;
        factsList.appendChild(newFactItem);
    }
});