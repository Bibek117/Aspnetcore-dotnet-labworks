import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  number1: number | null = null;
  number2: number | null = null;
  operator: string = 'add'; // Specify operator as a string
  result: number | null = null;

   onOperatorChange(event: Event): void {
    this.operator = (event.target as HTMLSelectElement).value;
  }
  calculate(): void {
    if(this.number1 === null || this.number2 === null) {
      this.result = null;
      return;
    }
    switch(this.operator) {
      case 'add':
        this.result = this.number1 + this.number2;
        break;
      case 'subtract':
        this.result = this.number1 - this.number2;
        break;
      case 'multiply':
        this.result = this.number1 * this.number2;
        break;
      default:
        console.log('Invalid operator!');
  }

}
}
