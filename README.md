## ROT13

The goal of this challenge is to implement a simple chipher called **ROT13**.

## Challenge Detail
- **ROT13** or "rotate by 13 places" works by replacing a character of the Latin alphabet by that which is 13 places away from it. 
- If `A` is the 1st character of the alphabet, it will be transformed to the 14th character, which is `N`.
- Please make sure you also transform capital characters.
- You should use [app.js](app.js) to solve the challenge and can refer tests [here](test/test1.js)

### Example

<table>
    <tr>
        <td><b>Input</b></td>
        <td>A</td>
        <td>B</td>
        <td>C</td>
        <td>D</td>
        <td>E</td>
        <td>F</td>
    </tr>
    <tr>
        <td><b>Output</b></td>
        <td>N</td>
        <td>O</td>
        <td>P</td>
        <td>Q</td>
        <td>R</td>
        <td>S</td>
    </tr>
</table>

[Reference](https://en.wikipedia.org/wiki/ROT13)

### Test Results *before* solving the challenge  
codecheck: Finish with code 2
codecheck: tests  : 3
codecheck: success: 1
codecheck: failure: 2
```

### Test Results *after* solving the challenge
```
codecheck: Finish with code 0
codecheck: tests  : 3
codecheck: success: 3
codecheck: failure: 0
```
--- --- ---
## Run Tests
To run tests locally install `codecheck` by running the following command in terminal 
```
$ npm install codecheck -g
```
To run tests in web editor please click in `RUN` button on left side of web editor

## Explain your code
In [answer.md](answer.md) write a brief explanation 
- About how your code works
- Problems faced while solving the challenge
- How you solved those problems
- Improvements/Feedbacks are also welcomed
