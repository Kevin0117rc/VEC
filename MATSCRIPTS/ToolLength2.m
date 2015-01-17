function cost = ToolLength2(ToolL,longM2,commandsM2)
%Tool L is guess
%

%Compute the distance between measured points
%each measurement is a X, Y, Z row vector
d12 = norm(longM2(1,:)-longM2(2,:));
d23 = norm(longM2(2,:)-longM2(3,:));
d13 = norm(longM2(1,:)-longM2(3,:));

%Compute predicted tool tip positions using fkin
%Each command is a j1-j5 row vector
Phi = zeros(175,1);
Tn1 = nfkin(commandsM2(1,:),ToolL,eye(4));
Tn2 = nfkin(commandsM2(2,:),ToolL,eye(4));
Tn3 = nfkin(commandsM2(3,:),ToolL,eye(4));

%Compute distances between predicted tool tip positions
Pd12 = norm(Tn1(1:3,4)-Tn2(1:3,4));
Pd23 = norm(Tn2(1:3,4)-Tn3(1:3,4));
Pd13 = norm(Tn1(1:3,4)-Tn3(1:3,4));

cost = norm([(d12-Pd12);(d23-Pd23);(d13-Pd13)]);

end