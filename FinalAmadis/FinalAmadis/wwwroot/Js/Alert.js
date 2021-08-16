function Confirmar(icon, title, text) {
    return new Promise(Resolve => {
        Swal.fire({
            icon,
            title,
            text
        })
    })
}

function HideModal() {
    $('#EliminarProducto').modal('hide')
    $('#EliminarProducto').modal({
        keyboard: false
    })
}