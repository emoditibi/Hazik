// Full house vizsgálata
if (parokSzama === 2 && drilling) {
  pontszam += Object.values(parok)[0] + Object.values(parok)[1] + drillingSum;
  window.alert("Full house!");
}
// Drilling vizsgálata
let drilling = false;
let drillingSum = 0;
for (let i = 1; i <= 6; i++) {
  if (szamlalo[i] >= 3) {
    drilling = true;
    drillingSum = i * 3;
    break;
  }
}
if (drilling) {
  pontszam += drillingSum;
  window.alert("Drilling!");
}
