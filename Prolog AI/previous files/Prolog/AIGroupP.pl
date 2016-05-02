% kathy(Stimuli, Response). to get it to work
kathy(Stimuli, Response) :-
    open('Input.txt', read, Str),
    read(Str,Stimuli),
    close(Str),
    write(Stimuli),
    template(InternalStimuli, InternalResponse),
    match(InternalStimuli, Stimuli),
    match(InternalResponse, Response),
    open('Output.txt',write,Stream),
    write(Stream,Response),  nl(Stream),
    close(Stream),
    !.

template([s([hello])], [s([hello, how, are, you,?])]).
template([s([hey])], [s([hello, how, are, you,?])]).
template([s([hi])], [s([hello, how, are, you,?])]).

/** saying im fine! **/
template([s([im, fine, how, are, you, ?])], [s([im, fine, too, thanks, for, asking, are, you, ready, to, start, the, interview, ?])]).
template([s([im, fine, you, ?])], [s([im, fine, too, thanks, for, asking, are, you, ready, to, start, the, interview, ?])]).
template([s([im, fine])], [s([ok, are, you, ready, to, start, the, interview, ?])]).

/** initiating questions! **/
template([s([yes])], [s([what, role, do, you, usually, take, when, working, in, a, team, ?])]).
template([s([ok])], [s([what, is, your, usual, role, in, a, team, ?])]).
template([s([lets, begin])], [s([what, is, your, usual, role, in, a, team, ?])]).

/** replying to user responces! **/
/** currently needs improvement! **/
template([s([i, am]), s(X)], [s([why,are,you]),s(X),w('?')]).
template([s(X), s([because])], [s([thank, you, for, telling, me, more, about]), s(X)]).
template([w(i),s(X),w(you)], [s([why,do,you]),s(X),w(me),w('?')]).





match([],[]).
match([Item|Items],[Word|Words]) :-
    match(Item, Items, Word, Words).

match(w(Word), Items, Word, Words) :-
    match(Items, Words).

match(s([Word|Seg]), Items, Word, Words0) :-
    append(Seg, Words1, Words0),
    match(Items, Words1).
