import { toggleListVisibility, updateVisibilityUI } from "./uiManager.js";
import { addItem, renderList } from "./itemManager.js";

function initializeApp() {
  updateUi();
  itmeManger();
}

function updateUi() {
  const showButton = document.getElementById("toggleListVisibility");
  const defaultUIVisible = false;

  showButton.addEventListener("click", () => {
    const isVisible = toggleListVisibility();
    updateVisibilityUI(isVisible);
  });

  updateVisibilityUI(defaultUIVisible);
}

function itmeManger() {
  const addButton = document.getElementById("addItemButton");
  const itemInput = document.getElementById("itemInput");

  addButton.addEventListener("click", () => {
    const newItem = itemInput.value;
    if (addItem(newItem)) {
      itemInput.value = "";
      renderList("listContainer");
    }
  });
}

window.addEventListener("DOMContentLoaded", initializeApp);
