def A051626(n):

#    if isA003592(n):
#
#        return 0
#
#    else:

	lpow=1

	while True:

	    for mpow in range(lpow-1, -1, -1):

	        if (10**lpow-10**mpow) % n == 0:

	            return lpow-mpow
	    lpow += 1