import Introduction from "./Introduction";
import {
  BrowserRouter as Router, Route, Routes
} from "react-router-dom";
import DescriptionComponent from "./components/DescriptionComponent";

function App() {
  return (
   <Router>
       <Routes>
          <Route path="/" element={<Introduction />} />
          <Route path="/Description" element={<DescriptionComponent />} />
        </Routes>
   </Router>
  );
}

export default App;
