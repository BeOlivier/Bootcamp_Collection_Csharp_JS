import React from 'react';
import { useState , useEffect} from 'react';

function App() {
  const [quotes, setQuote] = useState([]);
  useEffect(() => {
    fetch('https://localhost:7155/api/MovieQuotes/6')
    .then(res => res.json())
    .then(data => setQuote(data))
  console.log(quotes);
  }, []);

console.log(quotes);
  
  return (
    <>
    <div className="App">
      <h1>Movie Quotes</h1>
      <div>{quotes.quote}</div>
    </div>
    </>
  );
}

export default App;