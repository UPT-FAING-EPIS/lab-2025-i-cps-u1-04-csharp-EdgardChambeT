
---

### **2. Para el proyecto ATM (Command Pattern)**

#### **ATM/disenio.md**
```markdown
# Diagrama de Clases - Patrón Command

```mermaid.md
classDiagram
    direction TB

    %% Receiver
    class Account {
        +int AccountNumber
        +decimal AccountBalance
        +Withdraw(decimal amount)
        +Deposit(decimal amount)
    }

    %% Command Interface
    class ICommand {
        <<interface>>
        +Execute()
    }

    %% Commands Concretos
    class WithdrawCommand {
        -Account _account
        -decimal _amount
        +Execute()
    }

    class DepositCommand {
        -Account _account
        -decimal _amount
        +Execute()
    }

    %% Invoker
    class ATM {
        -ICommand _command
        +Action()
    }

    %% Relaciones
    ICommand <|-- WithdrawCommand
    ICommand <|-- DepositCommand
    WithdrawCommand --> Account
    DepositCommand --> Account
    ATM o-- ICommand
