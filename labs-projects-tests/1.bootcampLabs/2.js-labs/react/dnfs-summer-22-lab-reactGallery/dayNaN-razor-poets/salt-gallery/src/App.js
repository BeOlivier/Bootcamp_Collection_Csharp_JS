import logo from './logo.svg';
import './App.css';
import Gallery from './components/gallery';
import React, { useState, useMemo, useEffect, useRef, createContext, useContext } from 'react';

// const getData = async () => {
//   const response = await fetch('https://api.unsplash.com/photos/?client_id=2urGQfiRf39ba1KGqsbQwkc8xuBpYidZDAX9b7hjj4A');
//   const data = await response.json();
//   const imageLinks = [];
//   data.forEach(item => imageLinks.push(item.urls.small));
//   return imageLinks;
// }
const ImageContext = createContext(null)
function App() {

  const [images, setImages] = useState([]);

  useEffect(() => {
    const getData = async () => {
      const response = await fetch('https://api.unsplash.com/photos/?client_id=2urGQfiRf39ba1KGqsbQwkc8xuBpYidZDAX9b7hjj4A');
      const data = await response.json();
      const imageLinks = [];
      data.forEach(item => imageLinks.push(item.urls.small));
      setImages(imageLinks);
    }
    getData()

  },[])


  return (
    <div>
      app
      <ImageContext.Provider value={images}>
        <Gallery />
      </ ImageContext.Provider>
    </div>
  );
}

export {ImageContext};
export default App;
