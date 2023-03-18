
const pontszamElem = document.getElementById("pontszam");
var sv = 0;
var pontszam = 0;
var dobasok=new Array();

function veletlenszam(mettol,meddig){
    return Math.floor(Math.random()*(meddig-mettol+1)+mettol);
}
function megjelenit(){
    const div=document.getElementById("kockak");
    for (const i in  dobasok) {
        let kep=document.createElement("img");
        kep.src=dobasok[i].ertek+".png";
        kep.dataset.index=i;
        kep.setAttribute("onclick","kattintas(this)");
        div.appendChild(kep);
        dobasok[i].kep=kep;
    }
    console.log(dobasok);
}
function dobas(){
    for(let i=0;i<5;i++){
        const kocka={
            ertek:0,
            dobhate:true
        }
        dobasok.push(kocka);
    }
    megjelenit();


    /*
    for(let i=0;i<5;i++){
        console.log(dobasok[i]);
    }
    for (const index in dobasok) {// kulcs alapján (index)
        console.log(index,dobasok[index]);
            
        }
    for (const elem of dobasok) {
        console.log(elem);
    }*/
    }
dobas();

function porog(kocka){
    kocka.ertek=veletlenszam(1,6);
    kocka.kep.src=kocka.ertek+".png";

}
function kattintas(kocka){
    clearInterval(dobasok[kocka.dataset.index].idozites);
    mentes(kocka);

    
}
function porget() {
    dobasok.forEach(kocka => {
    kocka.idozites=setInterval(porog,100,kocka)
   
    });
}
function mentes() {
    var eredmenyek = [];
    for (let kocka of dobasok) {
      eredmenyek.push(kocka.ertek);
    }
    console.log(eredmenyek);
    
  }
  function vizsgalat() {
    let szamlalo = {};
    let parok = {};
    for (let i = 0; i < dobasok.length; i++) {
      const kocka = dobasok[i];
      if (kocka.ertek in szamlalo) {
        if (kocka.ertek in parok) {
          parok[kocka.ertek] += kocka.ertek;
        } else {
          parok[kocka.ertek] = kocka.ertek * 2;
        }
      } else {
        szamlalo[kocka.ertek] = 1;
      }
    }
    let parokSzama = Object.keys(parok).length;
    if (parokSzama === 1) {
      pontszam += Object.values(parok)[0];
      window.alert("Egy pár!");
    } else if (parokSzama === 2) {
      pontszam += Object.values(parok)[0] + Object.values(parok)[1];
      window.alert("Két pár!");
    }
    console.log(pontszam);
     sv += pontszam;
    pontszamElem.innerHTML = sv;
    pontszam = 0;

  }
