import React,{useState} from 'react';


export const Table=({tableHeader, tableData}) => {
    const headersRender = tableHeader.map((header, index)=>{
    return (
        <th key={index}>
            {header}
        </th>
    )
})

return(
    <table>
        <thead>
            <tr>
                {headersRender}
            </tr>
        </thead>
        <tbody>
            {tableData}
        </tbody>
    </table>
    )
}