/* eslint-disable no-console */

// object = {data: , id: , name: , favResType: , postalCode: , postalArea: , restaurants: , path:}


const getData = (obj) => {
    fs.readFile(obj.path, 'utf-8', (err, data) => {
        if (err) {
            console.log(err);
            return -1;
        }
        console.log(data);
        obj.data = fileDataToArray(data);
    });
    return obj;
}
//
// fs.readFile('./data/instructors.txt', (err, instructorData) => {
//     if (err) {
//         console.log(err);
//         return -1;
//     }
//     return instructorData;
// });

const promiseAdd = (num1, num2) => {
    return new Promise((resolve, reject) => {
        if (!Number.isInteger(num1) || !Number.isInteger(num2)){
            reject(Error("ayy lmao"));
        }
        resolve(num1 + num2);
    });
}

const isNum3 = (num) => {
    if (num === 3)
    {
        return { name: "oliver", lol: "vlad", kek: "eirik", lmao: ["arrray", "aouch"] }
    }
}




const fs = require('fs');
const lab = require('./labUtils');
const {fileDataToArray, printRestoList} = require("./labUtils");

const instructorId = process.argv[2] || '1';
console.log(`in index-promise.js with the instructor id '${instructorId}'`);


function nameFunction(obj) {
    const name = obj.data;
    for(i = 0; i < name.length; i++)
    {
        console.log(name[i][0]);
        if (name[i][0] == id)
        {
            obj.name = name[i][1];
        }
    }
    obj.path = './data/addresses.txt';
    return obj;
}

function addressFunction(obj) {
    const addresses = obj.data;
    obj.postalCode = addresses.find(element => element[0] === obj.id)[1];
    obj.path = './data/favoriteRestaurantType.txt';
    return obj;
}

function favoriteRestaurantFunction(obj) {
    const resTypes = obj.data;
    obj.favResType = resTypes.find(element => element[0] === obj.id)[1];
    obj.path = './data/postalAdressForPostalCode.txt';
    return obj;
}

function postalArea(obj) {
    const areas = obj.data;
    obj.postalArea = areas.find(element => element[0] === obj.postalCode)[1];
    obj.path = './data/restaurantsInArea.txt';
    return obj;
}

function restaurantsFinder(obj) {
    const restaurants = obj.data;
    const vars =  restaurants.filter(element => element[0] === obj.postalArea && element[1] === obj.favResType);
    for (i = 0; i < vars.length; i++) {
        obj.restaurants.push(vars[i][2]);
    }
    return obj;
}

// './data/instructors.txt'
// './data/addresses.txt'
// './data/favoriteRestaurantType.txt'
// './data/postalAdressForPostalCode.txt'
// './data/restaurantsInArea.txt'

const pathAssign = obj => {
    return new Promise((resolve) => {
        resolve(obj = {path: './data/instructors.txt', data: [], id: instructorId, name: '', favResType: '', postalCode: '', postalArea: "", restaurants: []});
    });
}

const OVERMIND = id => {
    const obj = {path: '', data: [], id: id, name: '', favResType: '', postalCode: '', postalArea: '', restaurants: []};
    
    // nameFunction(id).then(result => console.log(result));
    // let value = 0;
    // promiseAdd(1, 2).then(result => value = result).then(val => isNum3(val)).then(res => printRestoList(res.name, res.name, res.lol, res.lmao));
    // console.log(value);
    // console.log(id);
    pathAssign(obj)
        .then(result => fs.readFile('./data/instructors.txt', 'utf-8', (err, data) => {
            if (err) {
                console.log(err);
                return -1;
            }
            console.log(result);
            result.data = fileDataToArray(data)}))
        .then(result => console.log(result))
        .then(result => nameFunction(result))
        .then(result => getData(result))
        .then(result => addressFunction(result))
        .then(result => getData(result))
        .then(result => favoriteRestaurantFunction(result))
        .then(result => getData(result))
        .then(result => postalArea(result))
        .then(result => getData(result))
        .then(result => restaurantsFinder(result))
        .then(result => printRestoList(result.name, result.favResType, result.postalArea, result.restaurants));
    
}

OVERMIND(instructorId);