import React from 'react'
import { useState } from 'react'
const Calculator = () => {
    const [numbers, setNumbers] = useState({num1: 0, num2: 0,operator: '+'})
    const [result, setResult] = useState(0)
    const handleChange = (e) => {
       setNumbers({
            ...numbers,
            [e.target.name]: e.target.value
       })
    }
    const handleSubmit = (e) => {
        e.preventDefault()
        const {num1, num2,operator} = numbers
        console.log(num1, num2,operator)
        setResult(eval(`${num1} ${operator} ${num2}`))
    }

  return (
    <div className='calculator_container'>
        <h1>Calculator</h1>
        <form onSubmit={handleSubmit}>
            <input type="text" onChange={handleChange} name="num1" required placeholder="Enter first number" />
            <br />
            <input type="text" onChange={handleChange} name="num2" required placeholder="Enter second number" />
            <br />
            <select onChange={handleChange} name="operator">
                <option selected value="+">Add</option>
                <option value="-">Subtract</option>
                <option value="*">Multiply</option>
            </select>
            <button type="submit">Calculate</button>
        </form>
        <div className='result_display'>
            Result: <span>{result}</span>
        </div>
    </div>
  )
}
export default Calculator