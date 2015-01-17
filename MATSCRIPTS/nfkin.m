function A = nfkin(q,toolLength,T1b)
%q list of numbers, commands 1-5
%toolLength = 8 or 12 for long short tool
%T1b is transofrmation from T.m

%A is a 4x4 matrix A

%Kinematic Chain TxTyTzRzRy
% persistent T1b
% if isempty (T1b)
%     load('T1b.mat');
% end
X = q(1);
Y = q(2);
Z = q(3);
C = q(4);
B = q(5);
%%

 %%
 Toffset =7.409;  %%offset
 T0 = [1 0 0 0;0 1 0 0;0 0 1 -Toffset-toolLength;0 0 0 1];
 Transx = [1 0 0 X;0 1 0 0;0 0 1 0;0 0 0 1;];
 Transy = [1 0 0 0;0 1 0 Y;0 0 1 0;0 0 0 1;];
 Transz = [1 0 0 0;0 1 0 0;0 0 1 Z;0 0 0 1;];
 Crad = C*pi/180;
 Rotz = [cos(Crad) -sin(Crad) 0 0;sin(Crad) cos(Crad) 0 0;0 0 1 0;0 0 0 1];
 Brad = B*pi/180;
 Roty = [cos(Brad) 0 sin(Brad) 0;0 1 0 0;-sin(Brad) 0 cos(Brad) 0;0 0 0 1];
 A = T1b*Transx*Transy*Transz*Rotz*Roty*T0;

 end
% 
