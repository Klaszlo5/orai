const categories = ["szegények pénze", "középosztály pénze", "gazdagok pénze"];
const fulimData = Array.from({ length: 20 }, (_, index) => {
  const value = Math.floor(Math.random() * 10000) + 1;
  return {
    id: index + 1,
    value: value,
    type: value % 2 === 0 ? "páros" : "páratlan",
    category: categories[Math.floor(Math.random() * categories.length)],
  };
});

document.addEventListener("DOMContentLoaded", () => {
  const tableBody = document.querySelector("#fulium-table tbody");
  const categoryFilter = document.querySelector("#category-filter");
  const minValueInput = document.querySelector("#min-value");
  const maxValueInput = document.querySelector("#max-value");

  function renderTable(data) {
    tableBody.innerHTML = "";
    data.forEach((item) => {
      const row = document.createElement("tr");
      row.innerHTML = `<td>${item.id}</td><td>${item.value}</td><td>${item.type}</td><td>${item.category}</td>`;
      tableBody.appendChild(row);
    });
  }
  document.getElementById("apply-filters").addEventListener("click", () => {
    let filteredData = [...fulimData];
    const selectedCategory = categoryFilter.value;
    if (selectedCategory !== "all") {
      filteredData = filteredData.filter(
        (item) => item.category === selectedCategory
      );
    }
    const minValue = parseInt(minValueInput.value) || 0;
    const maxValue = parseInt(maxValueInput.value) || Infinity;
    filteredData = filteredData.filter(
      (item) => item.value >= minValue && item.value <= maxValue
    );

    renderTable(filteredData);
  });
  //   let uniqueValue = new Set();
  //   for (let i = 0; i < fulimData.length; i++) {
  //      uniqueValue=  new Set(fulimData[i].value)

  //   }
  //   console.log(uniqueValue.size);
  //   console.log(fulimData.map(item => item.value));
  let uniqueValueCount = new Set(fulimData.map((item) => item.value)).size;
  document.getElementById(
    "result"
  ).textContent = `Egyedi fülium értekek száma: ${uniqueValueCount}`;

  const categorySums = fulimData.reduce((acc, item) => {
    acc[item.category] = (acc[item.category] || 0) + item.value;
    return acc;
  }, {});
  const maxCategory = Object.keys(categorySums).reduce((a, b) => 
    categorySums[a] > categorySums[b] ? a : b);
  document.getElementById(
    "result2"
  ).textContent = `Legnagyobb kategória ${maxCategory} (${categorySums[maxCategory]} fülium)`;
  renderTable(fulimData);
});
