/* eslint-disable no-console */
const fs = require('fs');
const lab = require('./labUtils');
const {printRestoList, fileDataToArray} = require("./labUtils");

const instructorId = process.argv[2] || '1';
console.log(`in index-cb.js with the instructor id '${instructorId}'`);


function nameFunction(id, data) {
  const name = fileDataToArray(data);
  let instructor = "";
  for(i = 0; i < name.length; i++)
  {
    if (name[i][0] == id)
    {
      instructor = name[i][1];
    }
  }
  return (instructor);
}

function addressFunction(id, data) {
  const addresses = fileDataToArray(data);
  return addresses.find(element => element[0] === id)[1];
}

function favoriteRestaurantFunction(id, data) {
  const resTypes = fileDataToArray(data);
  return resTypes.find(element => element[0] === id)[1];
}

function postalArea(postalCode, data) {
  const areas = fileDataToArray(data);
  return areas.find(element => element[0] === postalCode)[1];
}

function restaurantsFinder(type, area, data) {
  const result = [];
  const restaurants = fileDataToArray(data);
  const vars =  restaurants.filter(element => element[0] === area && element[1] === type);
  for (i = 0; i < vars.length; i++) {
    result.push(vars[i][2]);
  }
  return result;
}


// EXERCISE ONE

function OVERMIND(id){
  const result = {};
  fs.readFile('./data/instructors.txt', 'utf-8', (err, instructorData) => {
    if (err) {
      console.log(err);
      return -1;
    }
    const name = nameFunction(id, instructorData);
    result.name = name;
    fs.readFile('./data/addresses.txt', (err, addressData) => {
      if (err) {
        console.log(err);
        return -1;
      }
      const address = addressFunction(id, addressData);
      result.address = address;
      fs.readFile('./data/favoriteRestaurantType.txt', (err, faveResData) => {
        if (err) {
          console.log(err);
          return -1;
        }
        const restType = favoriteRestaurantFunction(id, faveResData);
        result.restType = restType;
        fs.readFile('./data/postalAdressForPostalCode.txt', (err, postalAreaData) => {
          if (err) {
            console.log(err);
            return -1;
          }
          const areaName = postalArea(result.address, postalAreaData);
          result.areaName = areaName;
          fs.readFile('./data/restaurantsInArea.txt', (err, restData) => {
            if (err) {
              console.log(err);
              return -1;
            }
            const restArray = restaurantsFinder(result.restType, result.areaName, restData);
            result.restArray = restArray;
            printRestoList(result.name, result.restType, result.address, result.restArray);
          })
        })
      });
    });
  });
  
}

OVERMIND(instructorId);






