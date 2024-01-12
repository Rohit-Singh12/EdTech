import Introduction from "./Introduction";
import {
  BrowserRouter as Router, Route, Routes
} from "react-router-dom";
import DescriptionComponent from "./pages/DescriptionComponent";
import FormPage from "./pages/FormPage";

function App() {
  return (
   <Router>
       <Routes>
          <Route path="/" element={<Introduction />} />
          <Route path="/Description" element={<DescriptionComponent />} />
          <Route path="/login" element={<FormPage />} />
        </Routes>
   </Router>
  );
}

export default App;
