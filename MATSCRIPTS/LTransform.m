function [Ahat,RhatD] = LTransform(m1,commands,phi,ToolLength)
% m1=COMP(1:20,:);
% m2=long(1:20,:);
for i=1:max(size(commands))
A=fkin(commands(i,:),phi,ToolLength,eye(4));
m2(:,i)=A(1:3,4);
end
%m2=m2';
m1=m1';
%Centroid of measurement set 1
dbar = mean(m1,2);
for k=1:size(m1,2)
    dc(:,k) = m1(:,k) - dbar;
end

%Centroid of measurement set 2
mbar = mean(m2,2);
for r = 1:size(m2,2)
    mc(:,r) = m2(:,r) - mbar;
end

%Calculate the Correlation matrix
H = zeros(3,3);
for l=1:size(m2,2)
    Hstar(:,:,l) = mc(:,l)*dc(:,l)';
end
H = sum(Hstar,3);
%Optimal rotation matrix
[U,S,V] = svd(H);
Rhat = V*U';

%Optimal translation vector
That = dbar - Rhat*mbar;

%Complete optimal transformation
Ahat = [Rhat That;0 0 0 1];

%Check determinant of Rhat for a good transformation
RhatD = det(Rhat);

end
