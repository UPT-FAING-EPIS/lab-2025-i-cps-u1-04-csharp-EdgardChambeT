# Diagrama de Clases - Patrón Strategy

```mermaid.md
classDiagram
    direction TB
    
    %% Interfaz Estrategia
    class IPaymentStrategy {
        <<interface>>
        +Pay(double amount) bool
    }

    %% Estrategias Concretas
    class CreditCardPaymentStrategy {
        +Pay(double amount) bool
    }
    
    class DebitCardPaymentStrategy {
        +Pay(double amount) bool
    }
    
    class CashPaymentStrategy {
        +Pay(double amount) bool
    }

    %% Contexto
    class PaymentContext {
        -IPaymentStrategy _strategy
        +SetPaymentStrategy(IPaymentStrategy strategy)
        +Pay(double amount) bool
    }

    %% Service
    class PaymentService {
        +ProcessPayment(int type, double amount) bool
    }

    %% Relaciones
    IPaymentStrategy <|-- CreditCardPaymentStrategy
    IPaymentStrategy <|-- DebitCardPaymentStrategy
    IPaymentStrategy <|-- CashPaymentStrategy
    PaymentContext o-- IPaymentStrategy
    PaymentService --> PaymentContext