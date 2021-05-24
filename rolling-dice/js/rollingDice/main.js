// Put your code here
const roll = () => {
    let dieValue = Math.floor(Math.random() * 6) + 1;
    die = dieValue
    return die
}

const getRoll = () => {
    for (let i = 0; i < 10; i++) {
        let die1 = roll();
        let die2 = roll();
        if (die1 === die2) {
            console.log(`"${die1} + ${die2} = ${die1 + die2} DOUBLES!"`)
        } else {
            console.log(`"${die1} + ${die2} = ${die1 + die2}"`)
        }
    }
}
getRoll();
