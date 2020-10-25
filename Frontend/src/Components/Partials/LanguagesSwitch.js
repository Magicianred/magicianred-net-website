import React from 'react';
import Nav from 'react-bootstrap/Nav';

const publicUrl = process.env.PUBLIC_URL;

const LanguagesSwitch = () => {
    return (
        <div style={{ display: "block", float: "right" }}>
            {/* <a className="btn btn-small" id="it_link" href={`${publicUrl}/#/it/`}>it</a>
            <a className="btn btn-small" id="en_link" href={`${publicUrl}/#/en/`}>en</a> */}
            {/* <a className="btn btn-small" id="ge_link" href={`${publicUrl}/#/de/`}>de</a>
            <a className="btn btn-small" id="es_link" href={`${publicUrl}/#/es/`}>es</a> */}
        </div>
    );
}

export default LanguagesSwitch;