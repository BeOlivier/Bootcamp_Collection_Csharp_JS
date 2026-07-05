import React, { useState, useMemo, useEffect, useContext, useRef } from 'react';
import Picture from './picture.js';
import {ImageContext} from "../App";

const Gallery = () => {
    const images = useContext(ImageContext)

    return (
            <div>
                gallery
                {images.map(img =>
                    ( <Picture picture={img}/> ))}
            </div>
            );
}

export default Gallery;