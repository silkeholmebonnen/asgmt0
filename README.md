# asgmt0

```mermaid
graph TD
    A(Is it divisible by 4?) -->|Yes| B(Is it divisible by 100?)
    A -->|No| C(It is not leap year)
    B -->|Yes| D(Is it divisible by 400?) 
    B -->|No| E(It is leap year) 
    D -->|Yes| F(It is leap year) 
    D -->|No| G(It is not leap year)
    
    ```
