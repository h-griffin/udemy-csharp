# C# Basics 
```
const float Pi = 3.14f;

camel case : firstName - local vars
pascal case : FirstName - constants

byte: 0 - 255
short: -32,768 - 32,767
int: -2.1B - 2.1B

defualt type is double, must specify what kind of num (float)
                   v
float number = 1.2f;   < f float
decimal number = 1.2m; < m decimal
```

### OVERFLOWING ###
```
byte number = 255;
number = number + 1; //0 out of bounds

checked
{
    byte number = 255;
    number = number + 1;
}

^^over flow will not happend with checked keyword
```

### SCOPE ###
```vars available inside block and children```

### CONVERT ###
```
byte     1 bytes
short    2
int      4
long     8

toByte()   > byte
toInt16() > short
toInt32() > int
toint64() > long
```

### LOGICAL OPERATORS ###
```
Boolean algebra are conjunction (AND), disjunction (OR) andnegation (NOT).
- Logical AND operator is indicated by &&.
    z = x && y
    z is true if both x and y are true; otherwise, it’ll be false.

- Logical OR is indicated by two vertical lines (||). 
    z = x || y
    z will be true, if either x or y is true.

- Logical NOT operator in C# is indicated by an exclamation mark (!) and it reverses the value of a
given variable or expression:
    y = !x
    if x is true, y will be false, and if x is false, y will be true.

Clean Coding
x: isOver18
y: isCitizen
z: isEligible

it’s a good practice to prefix Boolean names with IS or HAS (if possible).
```

### COMMENTS ###
```
// single line

/* multi
line */
```

### Types ###
```
- structures - Value Types
    - Primitive Types (small - 8bytes)
    - Custom Structures

- classes - Reference Types
    - Arrays
    - Strings
    - Custom Classes

- structures - Value Types:
    - allocated on stack
    - memory allocation done automaticallu
    - immediatly removes when out of scope

-  classes - Reference Types:
    - you need to allocate memory
    - memmory allocated on heap (more sustainable)
    - garbage collected by CLR
```
```
Create obj of type point

public class Point
{
    public int x;
    public int y;
}
Point p = new Point();
```

### CONDITIONAL STATEMENTS ###
```
if(){} - else if(){} - else{}

switch() case: break

Case:
Case: stacking shares code block
```

### ITERATION STATEMENTS ###
```
- For
    - for ( intitiation ; condition ; iteration )
    - for ( var i=0 ; 1<10 ; i++ )

- ForEach
    - foreach ( var number in numbers )
    - lists or arrays "enumarables"

- While
    - while ( i<10 )
    {
        ...
        i++
    }

- Do-While
    - do 
    {
        ...
        i++
    } while ( i<10 )

- Break : exit loop 
- Continue : skip tp next iteration

```

string builder

system.Text

no itteration methods , manipulation methods only
append insert remove ...