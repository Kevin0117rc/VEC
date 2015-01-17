%Tool length and tool transform

%Manually load the measurements
%Load commands from file
%load('commands.mat')

%Find the long tool
%Long Tool Length
%Include more points if errors are large
Tl =fminsearch(@(Tl) ToolLength2(Tl,longM2(1:10,1:3),commandsM2(1:10,1:5)),1)

%Find the transformation
%Note: only include points you are certain are aligned. Minimum of 6.
T0L=LTransform(longM2(1:10,:),commandsM2(1:10,:), zeros(175,1), Tl); 

%commands are a csv file, coming from machine decode

%Save both variables
save('LTransformation.mat', 'T0L')
save('Tool.mat', 'Tl')

%%
%Short tool length
%comment out until ready
%M2T = sqrt((long(:,1)-short(:,1)).^2+(long(:,2)-short(:,2)).^2+(long(:,3)-short(:,3)).^2);
%Ts=Tl-mean(M2T);
%save('ToolLengths.mat','Tl','Ts')

%%
%Predicted positions for alignment
for i=1:max(size(commands))
    a=fkin(commands(i,:), zeros(175,1), Tl,T0L);
    b(:,i)=a(1:3,4);
end
b=b';
save('nom_pos.mat','b')

