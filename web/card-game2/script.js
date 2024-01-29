const emojis = ["👓", "👓", "🎈", "🎈", "🎄", "🎄", "😎", "😎", "🥰", "🥰", "💔", "💔", "❤", "❤", "😋", "😋"];

let s_emojis = emojis.sort(() => Math.random() - 0.5); // Исправлено условие сортировки

for (let i = 0; i < emojis.length; i++) {
    let box = document.createElement('div');
    box.className = 'item';
    box.innerHTML = s_emojis[i];

    box.addEventListener('click', function () { // Исправлено 'onClick' на 'addEventListener'
        this.classList.add('boxOpen');

        setTimeout(() => {
            let openBoxes = document.querySelectorAll('.boxOpen');
            if (openBoxes.length > 1) {
                if (openBoxes[0].innerHTML === openBoxes[1].innerHTML) {
                    openBoxes.forEach(box => box.classList.add('boxMatch'));
                    openBoxes.forEach(box => box.classList.remove('boxOpen'));

                    if (document.querySelectorAll('.boxMatch').length === emojis.length) {
                        alert('Вы выиграли!');
                    }
                } else {
                    openBoxes.forEach(box => box.classList.remove('boxOpen'));
                }
            }
        }, 500);
    });

    document.querySelector('.game').appendChild(box);
}
