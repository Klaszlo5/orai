let isListVisible = false;

export function toggleListVisibility() {
  isListVisible = !isListVisible;
  return isListVisible;
}

export function updateVisibilityUI(isVisible) {
  const showButton = document.getElementById("toggleListVisibility");
  const listContainer = document.getElementById("listContainer");

  if (isVisible) {
    showButton.value = "Lista elrejtése";
    listContainer.style.display = "block";
  } else {
    showButton.value = "Lista megjelenitese";
    listContainer.style.display = "none";
  }
}
