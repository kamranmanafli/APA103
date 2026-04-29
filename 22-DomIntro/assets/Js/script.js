const app = document.getElementById("app");

const card = document.createElement("div");
Object.assign(card.style, {
  width: "350px",
  borderRadius: "12px",
  overflow: "hidden",
  boxShadow: "0 4px 15px rgba(0,0,0,0.2)",
  fontFamily: "Arial",
  cursor: "pointer",
  transition: "0.3s",
});

card.addEventListener("mouseenter", () => {
  card.style.transform = "scale(1.03)";
});

card.addEventListener("mouseleave", () => {
  card.style.transform = "scale(1)";
});

const imgContainer = document.createElement("div");
imgContainer.style.position = "relative";

const img = document.createElement("img");
img.src = "https://picsum.photos/500/300";
Object.assign(img.style, {
  width: "100%",
  display: "block",
});

const heart = document.createElement("div");
heart.innerHTML = "🤍";
Object.assign(heart.style, {
  position: "absolute",
  top: "10px",
  right: "10px",
  fontSize: "24px",
  cursor: "pointer",
});

let liked = false;
heart.addEventListener("click", (e) => {
  e.stopPropagation();
  liked = !liked;
  heart.innerHTML = liked ? "❤️" : "🤍";
});

imgContainer.appendChild(img);
imgContainer.appendChild(heart);

const content = document.createElement("div");
content.style.padding = "15px";

const title = document.createElement("p");
title.textContent = "DETACHED HOUSE • 5Y OLD";
title.style.color = "#777";

const price = document.createElement("h2");
price.textContent = "$750,000";

const address = document.createElement("p");
address.textContent = "742 Evergreen Terrace";
address.style.color = "#555";

const info = document.createElement("div");
info.style.display = "flex";
info.style.justifyContent = "space-between";

const bed = document.createElement("span");
bed.textContent = "🛏 3 Bedrooms";

const bath = document.createElement("span");
bed.textContent = "🛁 2 Bathrooms";

info.appendChild(bed);
info.appendChild(bath);

const realtor = document.createElement("div");
realtor.style.marginTop = "15px";

const name = document.createElement("p");
name.textContent = "Tiffany Heffner";
name.style.fontWeight = "bold";

const phone = document.createElement("p");
phone.textContent = "(555) 555-4321";
phone.style.color = "#777";

realtor.appendChild(name);
realtor.appendChild(phone);

content.appendChild(title);
content.appendChild(price);
content.appendChild(address);
content.appendChild(info);
content.appendChild(realtor);

card.appendChild(imgContainer);
card.appendChild(content);

app.appendChild(card);
