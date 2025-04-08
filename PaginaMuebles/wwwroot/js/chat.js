function sendMessage() {
    const input = document.getElementById("chat-input");
    const chatBox = document.getElementById("chat-box");
    const message = input.value.trim();

    if (message === "") return;

    const userMessage = document.createElement("div");
    userMessage.className = "mensaje usuario";
    userMessage.innerHTML = `<span class="nombre">Tú</span>: ${message}`;
    chatBox.appendChild(userMessage);
    chatBox.scrollTop = chatBox.scrollHeight;
    input.value = "";

    setTimeout(() => {
        const reply = document.createElement("div");
        reply.className = "mensaje carpintero";

        if (message.toLowerCase().includes("cotización")) {
            reply.innerHTML = `<span class="nombre">Carpintero</span>: ¡Claro! Te mostraremos el formulario.`;
            document.getElementById("cotizacion-form").style.display = 'block';
        } else {
            reply.innerHTML = `<span class="nombre">Carpintero</span>: Gracias por tu mensaje. En breve te responderemos.`;
        }

        chatBox.appendChild(reply);
        chatBox.scrollTop = chatBox.scrollHeight;
    }, 800);
}
