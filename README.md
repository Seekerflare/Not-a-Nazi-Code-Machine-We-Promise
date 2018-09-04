# Not-a-Nazi-Code-Machine-We-Promise
Creation of a virtual enigma machine, based on the design active during WW2 used by Germans
Group name: Love Patrol Alpha!
Group members: Kathryn Williams and Bjorn van der Veen
Project title: Operation: Confuse the Brits (or 'The Enigma Machine')
Project page: https://github.com/Seekerflare/Not-a-Nazi-Code-Machine-We-Promise

Instructions: What we intend to do is make a set of (hopefully animated) rotors that you can select the starting position of, as well as the particular order that they are in from the starting state, to encode whatever message you want. Currently deciding on whether to keep it historically accurate and have it run like a virtual electrical circuit to light up a specific letter that your input is changed to, which you would then have to write down on a piece of paper, letter by letter, which would then be sent off to your allies via telegram or pigeon or whatever, or whether we want it to just take a chunk of string input and turn it in to code. Leaning towards letter by letter, as it makes it more fun and accurate. The machine also acts as the decoder, so when your pigeon turns up all you have to do is have the correct starting state for the rotors, enter in the gibberish code that was received, and bingo bongo you have your message. Basically, you'll have an option to set up the starting state for the rotors (which you will need to write down to decode the message later) which will be done by either a drop-down menu, or by animated rotors(the dream), and you will then hit whatever keys you want on the keyboard to get your message encrypted. IMPORTANT TO NOTE!: There is no punctuation allowed, nor are there numbers. This is by design. These things would make the message easier to break. The rotors can be swapped around.

Tools used: undecided/undiscovered as of yet.

Concepts used: LOTS of string manipulation, most likely with arrays. The idea is that we convert the string to its ASCII number, mess around with that using the rotors (so adding to it, subtracting, wrapping it around so it stays in range, etc.) then converting it back to string after it has gone through the whole changing process. More to come as discovered.

Assumptions: Honestly, I'm expecting it to crash horribly. But failing that, it can be used to send secret messages to whomever you want, seeing as there are 1.0745868732725061^23 possible combinations. Try brute-forcing THAT quickly.

Limitations: Can't do anything outside of its scope, really.
