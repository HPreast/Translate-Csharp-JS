// Put your code here

const placeNames = [
    "Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"
]

console.log("All Place Names");
placeNames.map(name => {
    console.log(name)
})

const theNames = [];

placeNames.map(name => {
    if (name.startsWith("The")) {
        theNames.push(name)
    }
})
console.log("'The' Place Names");

theNames.map(name => {
    console.log(name)
})