import React, { useState, useMemo, useEffect, useRef } from 'react';

const Picture = ({picture}) => {
    return (
        <div>
            bildunderhär 
            <p>{picture}</p>
            <img src={picture}/>
        </div>
    )
}

export default Picture;