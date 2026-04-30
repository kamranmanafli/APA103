function calculate(operation) {
  let num1 = document.getElementById("num1").value;
  let num2 = document.getElementById("num2").value;
  let resultBox = document.getElementById("result");

  // boş input yoxlaması
  if (num1 === "" || num2 === "") {
    alert("Zəhmət olmasa bütün xanaları doldurun!");
    return;
  }

  num1 = Number(num1);
  num2 = Number(num2);

  let result;

  switch (operation) {
    case "plus":
      result = num1 + num2;
      break;
    case "minus":
      result = num1 - num2;
      break;
    case "mult":
      result = num1 * num2;
      break;
    case "divide":
      if (num2 === 0) {
        alert("0-a bölmək olmaz!");
        return;
      }
      result = num1 / num2;
      break;
    default:
      alert("Unknown operation");
      return;
  }

  resultBox.innerText = "Result: " + result;
}
