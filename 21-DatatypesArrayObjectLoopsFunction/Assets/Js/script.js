function removeDuplicatesAndCount(arr) {
  let result = [];
  let count = {};

  for (let i = 0; i < arr.length; i++) {
    let num = arr[i];

    if (!count[num]) {
      count[num] = 1;
      result.push(num);
    } else {
      count[num]++;
    }
  }

  console.log("Tekrarlananlarin sayi", count);
  return result;
}

console.log(removeDuplicatesAndCount([1, 2, 2, 3, 4, 4, 4]));

function isPalindrome(word) {
  let reversed = word.split("").reverse().join("");
  return word === reversed;
}

console.log(isPalindrome("level"));
console.log(isPalindrome("salam"));

function countSmaller(arr, num) {
  let count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] < num) {
      count++;
    }
  }

  return count;
}

console.log(countSmaller([1, 5, 3, 7, 2], 4));

function checkNumber(n) {
  let sum = 0;

  for (let i = 1; i < n; i++) {
    if (n % i === 0) {
      sum += i;
    }
  }

  if (sum > n) {
    return "Abundant";
  } else {
    return "Deficient";
  }
}

console.log(checkNumber(12));
console.log(checkNumber(13));

function squareArray(arr) {
  let result = [];

  for (let i = 0; i < arr.length; i++) {
    result.push(arr[i] * arr[i]);
  }

  return result;
}

console.log(squareArray([1, 2, 3, 4]));
