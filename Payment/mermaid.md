# Especificación Mermaid - Payment

## Elementos del Diagrama

### Clases Principales
- `IPaymentStrategy`: Interfaz para métodos de pago
- `PaymentContext`: Administra la estrategia seleccionada
- `PaymentService`: Fachada para el cliente

## Ejemplo de Flujo
```mermaid
sequenceDiagram
    Client->>PaymentService: ProcessPayment(1, 1000)
    PaymentService->>PaymentContext: SetStrategy(CreditCard)
    PaymentContext->>CreditCardStrategy: Pay(1000)
    CreditCardStrategy-->>Client: true