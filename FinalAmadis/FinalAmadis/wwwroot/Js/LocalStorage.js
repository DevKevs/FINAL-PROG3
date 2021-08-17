function storage(dato){
    sessionStorage.setItem(`Token`, dato);
}

function storagePicker(){
    return sessionStorage.getItem(`Token`);
}