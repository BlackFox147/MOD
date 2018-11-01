p = 0.5;
p1 = 0.4;
p2 = 0.4;

np = 1-p;
np1 = 1-p1;
np2 = 1-p2;

A = [p-1 p*np2 0 0 0 0 0 0;
    np p*p1-1 np*np2 p*p1*np2 0 0 p*p1 0;
    0 p*np1 p*p2-1 p*np1*np2+p*np1*p2 0 0 0 0;
    0 np*np1 np*p1 (p*p1*p2+np*np1*np2+np*np1*p2)-1 p*np1*p2 0 p*np1 0;
    0 0 0 np*p1*p2 (p*p1*p2+np*np1*np2+np*np1*p2)-1 p*np1*np2+p*np1*p2 0 p*np1;
    0 0 0 0 np*p1*p2 (p*p1*p2+np*p1*p2+np*np1*p2+np*np1*np2)-1 0 np*np1;
    0 np*p1 0 np*p1*np2 p*p1*np2 0 p*p1-1 np*p1;
    1 1 1 1 1 1 1 1];

B = [0;0;0;0;0;0;0;1]; 

P = linsolve(A,B);
fprintf('%1.4f \n', P);

p000 = P(1);
p010 = P(2);
p001 = P(3);
p011 = P(4);
p111 = P(5);
p211 = P(6);
p110 = P(7);
p210 = P(8);

Po = p + np*(p011*p2*np1 + p111*p2*np1 + p211*p2*np1);
fprintf('Po = %1.4f \n', Po);

Q = 1 - Po;
fprintf('Q = %1.4f \n', Q);

A = (p011 + p111 + p211 + p001)*np2;
fprintf('A = %1.4f \n', A);

Woh = ((p010 + p011)*p1 + (p110 + p111)*np1)*(1/np1)+((p110+p111)*p1 + (p210 + p211)*np1)*(2/np1);
fprintf('Woh = %1.4f \n', Woh);


