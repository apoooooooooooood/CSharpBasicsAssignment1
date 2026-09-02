Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };

STACK                              HEAP
┌─────────────────────┐            ┌────────────────────────────┐
│ o1                  │            │ Order object               │
│                     │            │                            │
│ Address: 0x100      │───────────▶│ OrderId = 1                │
└─────────────────────┘            │ CustomerName = "Ali"       │
                                   │ IsPaid = false              │
                                   └────────────────────────────┘
                                      Address: 0x100
         o1 holds a reference to the Order object created on the heap

Order o2 = o1;

STACK                              HEAP
┌─────────────────────┐            ┌────────────────────────────┐
│ o1                  │            │ Order object               │
│ Address: 0x100      │───────┐    │                            │
├─────────────────────┤       │    │ OrderId = 1                │
│ o2                  │       ├───▶│ CustomerName = "Ali"       │
│ Address: 0x100      │───────┘    │ IsPaid = false;               │
└─────────────────────┘            └────────────────────────────┘
                                      Address: 0x100

        o2 receives the same reference as o1, so both variables point to the same heap object 

o2.IsPaid = true;
STACK                              HEAP
┌─────────────────────┐            ┌────────────────────────────┐
│ o1                  │            │ Order object               │
│ Address: 0x100      │───────┐    │                            │
├─────────────────────┤       │    │ OrderId = 1                │
│ o2                  │       ├───▶│ CustomerName = "Ali"       │
│ Address: 0x100      │───────┘    │ IsPaid = true               │
└─────────────────────┘            └────────────────────────────┘
                                      Address: 0x100
        o2.IsPaid = true changes the same heap object's field, so the change is visible through both o1 and o2




 Point p1=new Point { X = 10, Y = 20 };
 Point p2= p1;
 STACK
┌──────────────────────┐
│ p1                   │
│ X = 10               │
│ Y = 20               │
├──────────────────────┤
│ p2                   │
│ X = 10               │
│ Y = 20               │
└──────────────────────┘

HEAP
┌──────────────────────┐
│       Nothing        │
│   related to p1/p2   │
└──────────────────────┘

       p2.x=30;
 STACK
 STACK
┌──────────────────────┐
│ p1                   │
│ X = 10               │
│ Y = 20               │
├──────────────────────┤
│ p2                   │
│ X = 30               │
│ Y = 20               │
└──────────────────────┘

HEAP
┌──────────────────────┐
│       Nothing        │
│   related to p1/p2   │
└──────────────────────┘
                                    تغيير أي من الاثنين لا يؤثر على الاخر لانها هنا value type وليست reference type


