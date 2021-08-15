function Confirmar(icon, title, text) {
    return new Promise(Resolve => {
        Swal.fire({
            icon,
            title,
            text
        })
    })
}