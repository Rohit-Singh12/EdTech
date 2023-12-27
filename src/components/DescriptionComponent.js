import { useState } from "react";
import TabsComponent from "./TabsComponent"
const DescriptionComponent = () => {
    const [title, setTitle] = useState("Machine Learning")
    return (
        
        <div className="course-info">
            <TabsComponent />
            <h1> {title} </h1>
        </div>
    )
}

export default DescriptionComponent;    