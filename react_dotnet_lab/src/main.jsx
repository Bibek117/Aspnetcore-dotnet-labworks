import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App'
import Layout from './Layout'
import Home from './Home'
import Calculator from './Calculator'
import './index.css'
import {createBrowserRouter,RouterProvider} from 'react-router-dom'



const router = createBrowserRouter([
  {
    path: '/',
    element: <Layout />,
    children: [
      { path: '/', element: <Home /> },
      { path: '/calculator', element: <Calculator /> },
    ]
  },
  {
    path:"/counter",
    element:<App/>
  }
])
ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
   <RouterProvider router={router} />
  </React.StrictMode>
)
