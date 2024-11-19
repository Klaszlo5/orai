let questions = [];

function addQuestion() {
  const question = document.getElementById("question").value;
  const correctAnswer = document.getElementById("correctAnswer").value;
  const options = document.getElementById("options").value.split(",");
  if (question && correctAnswer && options.length > 0) {
    let newQuestion = {
      id: questions.length + 1,
      question: question,
      correctAnswer: correctAnswer,
      options: options,
    };
    questions.push(newQuestion);
    alert("Kérdés mentve!");
    document.getElementById("questionForm").reset();
  } else {
    alert("Kérlek ad meg az összes adatot!");
  }
}
function randomQuestion() {
  if (questions.length === 0) {
    alert("Nincs több kérdés");
    return;
  }
  const randomIndex = Math.floor(Math.random() * questions.length);
  const currentQuestion = questions[randomIndex];
  questions.splice(randomIndex, 1);
  const div = document.createElement("div");
  const h2 = document.createElement("h2");
  h2.textContent = "Játék";
  const p = document.createElement("p");
  p.textContent = currentQuestion.question;
  div.append(h2, p);
  for (let i = 0; i < currentQuestion.options.length; i++) {
    const optionsElementContainer = document.createElement("div");
    const radio = document.createElement("input");
    radio.setAttribute("type", "radio");
    radio.setAttribute("name", `answer_${currentQuestion.id}`);
    radio.setAttribute("id", `option_${currentQuestion.id}_${i}`);
    radio.setAttribute("value", `${currentQuestion.options[i]}`);
    const label = document.createElement("label");
    label.setAttribute("for", `option_${currentQuestion.id}_${i}`);
    label.textContent = currentQuestion.options[i];
    optionsElementContainer.append(radio, label);
    div.append(optionsElementContainer);
  }
  document.querySelector("section").append(div);
}
