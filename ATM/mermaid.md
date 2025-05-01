# Especificación Mermaid - ATM

## Componentes Clave

### Roles del Patrón
- **Receiver**: `Account` (ejecuta operaciones reales)
- **Command**: `ICommand` (abstracción)
- **Invoker**: `ATM` (gestión de comandos)

```mermaid
sequenceDiagram
    Client->>ATM: new ATM(withdrawCommand)
    ATM->>WithdrawCommand: Execute()
    WithdrawCommand->>Account: Withdraw(100)
    Account-->>Client: Balance actualizado