// function print(){
//     console.log("Szia")
// }
// Call Stack
// let szam = 2;

// const szorzas = (x, y) => x * y;
// const negyzet = (x) => szorzas(x, x);
// const negyzetOsszeg = (a, b) => negyzet(a) + negyzet(b);

// console.log(negyzetOsszeg(2, 3));
// console.log("Szia")

// function first(){
//     second();
//     console.log("Elso");

// }
// function second(){
//     end();
//     console.log("Masodik")
// }
// function end(){
//     console.log("Vege")
// }

// first();

// console.log('Log 1')
// alert('Alert 1')
// console.log('Log 2')

// function idozito6ms() {
//   setTimeout(() => {
//     console.log("Log 2");
//   }, 6000);
// }
// function idozito2ms() {
//   setTimeout(() => {
//     console.log("Log 3");
//   }, 2000);
// }
// function idozito10ms() {
//     setTimeout(()=>{
//         console.log('Log 4')
//     }, 10000)
// }
// console.log('Log 1')
// idozito6ms();
// idozito2ms();
// idozito10ms();
// console.log('Log 5')

function generateBoostrapAlert(msg, type, time) {
  let alert = document.createElement("div");
  alert.textContent = msg;
  alert.classList.add("alert", `alert-${type}`);
  document.getElementById("alert_container").append(alert);
  setTimeout(() => {
    alert.remove();
  }, time);
}
setTimeout(()=>{
    generateBoostrapAlert("Sziasztok", "success", 6000);
},20000)
// setInterval(() => {
//     console.log('Szia')
// }, 5000);

let username = prompt("Kerem a neved: ");
console.log("Udv: " + username);
setTimeout(() => {
  let ans = prompt("Szeretne-e tovább menni a programban [igen/nem]: ");
  if (ans === "igen") {
    setTimeout(() => {
      console.log("Nagyszerű választás!");
      setTimeout(() => {
        console.log("A program véget ért.");
      }, 5000);
    }, 4000);
  } else if (ans === "nem") {
    setTimeout(() => {
      console.log(`Viszlát, ${username}!`);
      setTimeout(() => {
        console.log("A program véget ért.");
      }, 5000);
    }, 3000);
  }
}, 2000);
