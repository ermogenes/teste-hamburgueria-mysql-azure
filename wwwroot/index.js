const iniciar = async () => {
    const lista = document.getElementById('lista-burguers');
    const response = await fetch('/Burguers');
    const result = await response.json();
    result.forEach(burguer => lista.insertAdjacentHTML('beforeend',
        `<li>${burguer.nome} - ${burguer.preco}</li>`
    ));
};

document.addEventListener('DOMContentLoaded', iniciar);